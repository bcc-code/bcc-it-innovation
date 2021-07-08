# Output values go here
output "ip" {
  value = google_compute_address.vm_static_ip.address
}