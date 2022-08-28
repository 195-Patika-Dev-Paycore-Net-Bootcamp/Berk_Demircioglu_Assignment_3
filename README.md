# Waste Collection Project
# The Aim of the Project
A company is working on smart waste collection systems. A garbage collection or waste collection tool is expected to be the most optimal and efficient way to go through all points as soon as possible and collect all containers at least N times. 
# Project Details
- PostgreSQL with Hibernate ORM tool is used.
- 2 SQL tables were used in the system, which are the Container and Vehicle tables.
- While the Vehicle table holds the vehicles actively used in the field, the Container table holds the list of containers that each of these vehicles should visit and take during that day.
# Completed Tasks
- Vehicle and container tables were filled with at least 2 vehicles and 8 randomly container for each vehicle.
- Endpoints were added that list all the vehicles in the system and add a new vehicle.
- An endpoint that updates vehicle information has been added.
- A Delete endpoint was added to the system. It is coded in the way that if there is any container related with this vehicle, all information will also be deleted.
- The relationship between the Container and Vehicle was established over the vehicleId on the container.
- Endpoints were added that list all the container in the system and add a new container.
- An endpoint was added to update the information about the container without changing the vehicleId.
- An endpoint was added to delete a container.
- When a request was made with VehicleID, an endpoint was added to the vehicle that lists all the containers of that vehicle.
- A new endpoint was added, which takes VehicleID and n (number of clusters) as parameters. It was written to divide all the containers of this vehicle into equal elements with respect to a given N and to give all the results as a single response.
