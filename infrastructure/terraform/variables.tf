variable "location" {
  description = "Azure region for resources"
  type        = string
  default     = "East US"
}

variable "resource_group_name" {
  description = "Resource Group name"
  type        = string
}

variable "vm_name" {
  description = "bosch-jagathees"
  type        = string
}

variable "admin_username" {
  description = "jagathees"
  type        = string
}

variable "vm_size" {
  description = "Azure VM size"
  type        = string
  default     = "Standard_D2s_v3"
}

variable "admin_password" {
  description = "Jan@52152026"
  type        = string
  sensitive   = true
}

