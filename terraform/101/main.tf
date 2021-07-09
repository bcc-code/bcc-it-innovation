# Terraform configuration goes here
terraform {
  required_providers {
    google = {
      source  = "hashicorp/google"
      version = "3.5.0"
    }
  }
}


provider "google" {
  credentials = file(var.credentials_file)
  project = var.project
  region  = var.region
  zone    = var.zone
}

resource "google_project_service" "service" {
  project  = "bcc-learn-terraform"
  for_each = toset([
    "compute.googleapis.com",
    "oslogin.googleapis.com",
  ])
  service = each.key
}

resource "google_compute_network" "vpc_network" {
  name = "terraform-network"
  depends_on = [google_project_service.service]  
}

resource "google_compute_instance" "vm_instance" {
  name         = "terraform-instance"

  machine_type = var.machine_types[var.environment]
  tags         = ["web", "dev"]

  boot_disk {
    initialize_params {
        image = "cos-cloud/cos-stable"
    }
  }

  network_interface {
    network = google_compute_network.vpc_network.self_link
    access_config {
      nat_ip = google_compute_address.vm_static_ip.address
    }
  }
}

resource "google_compute_address" "vm_static_ip" {
  name = "terraform-static-ip"
}
