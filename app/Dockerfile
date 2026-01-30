FROM python:3.11-alpine

# Create non-root user
RUN addgroup -S appgroup && adduser -S appuser -G appgroup

WORKDIR /app

COPY app.py /app/app.py

# 🔐 Critical fix: upgrade packaging tools + pin Flask
RUN pip install --no-cache-dir --upgrade \
        pip \
        setuptools>=79.0.1 \
        wheel>=0.46.2 \
    && pip install --no-cache-dir flask==3.1.2

# Drop privileges
USER appuser

EXPOSE 5000

CMD ["python", "app.py"]

