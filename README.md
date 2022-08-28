# Waste Collection Project
# The Aim of the Project
A company is working on smart waste collection systems. A garbage collection or waste collection tool is expected to be the most optimal and efficient way to go through all points as soon as possible and collect all containers at least N times. 
# Project Details
- PostgreSQL with Hibernate ORM tool is used.
- 2 SQL tables were used in the system, which are the Container and Vehicle tables.
- While the Vehicle table holds the vehicles actively used in the field, the Container table holds the list of containers that each of these vehicles should visit and take during that day.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicletabledatabase.png)
<p align="center"> Figure 1. Vehicle Table </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containertabledatabase.png)
<p align="center"> Figure 2. Container Table </p>

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
## Project Structure and Explanations
![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/projectfilestructure.png)
<p> Figure 3. Project Layers </p>
## Business
It is the layer where business codes are written and validations are performed.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/businessclass.png)
<p> Figure 4. Business Folder Structure </p>

## Core 
It is the layer where the common classes are stored.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/coreclasslib.png)
<p> Figure 5. Core Folder Structure </p>

## DataAccess 
It is the layer in which the operations required to access the data are performed.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/dataaccessclasslib.png)
<p> Figure 6. DataAccess Folder Structure </p>

## Entities 
It is the layer where classes are generated corresponding to the database tables.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/entitiesclasslib.png)
<p> Figure 7. Entities Folder Structure </p>

## Web API
This allows the program to communicate with different applications such as IOS and Angular etc.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/webap%C4%B1.png)
<p> Figure 8. Web API Folder Structure </p>

## Results 
## Swagger Display

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/swagger.png)
<p align="center"> Figure 9. Swagger Display </p>

## Containers
## GetAll Method
- This method is used to obtain all the containers in the list.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containergetall_1.png)
<p align="center"> Figure 10. GetAll Method </p>

## Add Method
- This method is used to add a container with the parameters taken from body to the list.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containeradd1.png)
<p align="center"> Figure 11. Add Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containeradd2.png)
<p align="center"> Figure 12. After Add Method </p>

## Update Method
- This method is used to update the existing container according to the parameters taken from body to the list without changing vehicleId.
- If a container instance not on the list is tried to be updated, the program transmits the required message.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containerupdatebefore.png)
<p align="center"> Figure 13. Before Update Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containerupdate.png)
<p align="center"> Figure 14. Update Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containerupdateafter.png)
<p align="center"> Figure 15. Before Update Method </p>

## Delete Method
- This method is used to delete a container according to the parameters taken from body to the list.
- If a vehicle instance not on the list is tried to be deleted, the program transmits the required message.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containerdelete.png)
<p align="center"> Figure 16. Delete Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/containerdeleteafter.png)
<p align="center"> Figure 17. Delete Method </p>

## Vehicles
## GetAll Method
- This method is used to obtain all the vehicles in the list.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclegetall.png)
<p align="center"> Figure 18. GetAll Method </p>

## GetContainers Method
- This method is used to get all the containers that belong to a given vehicle in the list.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclegetcontainersbefore.png)
<p align="center"> Figure 19. Current Vehicle Table </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclegetcontainersafter.png)
<p align="center"> Figure 20. GetContainers Method Result </p>

## PartitionContainers Method
-This method is used to partition containers of the related vehicle with respect to a given chunk size.

The algorithm;
- Step 1: The logic behind this is that, for instance, there are 16 containers that belong to a vehicle and we want to split these containers into 5 separate groups.
- Step 2: If we divide 16 by 5, we obtain a quotient of 3. This quotient indicates that my first list length will be 3.
- Step 3: Then 16-3=13 containers and 4 groups remain to be partitioned. If we apply the same method stated in Step 2 to these parameters. We obtain the quotient as 13/4=3. Then my second list contains 3 number of elements. And so on.

16 / 5 = 3 => list length = 3 && 16 - 3 = 13 <br>
13 / 4 = 3 => list length = 3 && 13 - 3 = 10 <br>
10 / 3 = 3 => list length = 3 && 10 - 3 = 7 <br>
 7 / 2 = 3 => list length = 3 && 7 - 3 = 4 <br>
 4 / 1 = 4 => list length = 4 && 4 - 4 = 0 <br>

For example 13 container, 7 group;

13 / 7 = 1 => list length = 1 && 13 - 1 = 12 <br>
12 / 6 = 2 => list length = 2 && 12 - 2 = 10 <br>
10 / 5 = 2 => list length = 2 && 10 - 2 = 8 <br>
 8 / 4 = 2 => list length = 2 && 8 - 2 = 6 <br>
 6 / 3 = 2 => list length = 2 && 6 - 2 = 4 <br>
 4 / 2 = 2 => list length = 2 && 4 - 2 = 2 <br>
 2 / 1 = 2 => list length = 2 && 2 - 2 = 0 <br>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclepartitioncontainerbefore.png)
<p align="center"> Figure 21. Vehicle Table </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclepartitioncontainerafter1.png)
<p align="center"> Figure 22. PartitionContainers Method Example </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclepartitioncontainerafter2.png)
<p align="center"> Figure 23. PartitionContainers Method Results </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclepartitioncontainerafter3.png)
<p align="center"> Figure 24. PartitionContainers Method Results </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclepartitioncontainerafter4.png)
<p align="center"> Figure 25. PartitionContainers Method Results </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclepartitioncontainerafter5.png)
<p align="center"> Figure 26. PartitionContainers Method Results </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehiclepartitioncontainerafter6.png)
<p align="center"> Figure 27. PartitionContainers Method Results </p>

## Add Method
- This method is used to add a vehicle with the parameters taken from body to the list.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicleaddbefore.png)
<p align="center"> Figure 28. Before Add Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicleadd.png)
<p align="center"> Figure 29. Add Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicleaddafter.png)
<p align="center"> Figure 30. After Add Method </p>

## Update Method
- This method is used to update the existing vehicle according to the parameters taken from body to the list.
- If a vehicle instance not on the list is tried to be updated, the program transmits the required message.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicleupdatebefore.png)
<p align="center"> Figure 31. Before Update Method </p>


![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicleupdate.png)
<p align="center"> Figure 32. Update Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicleupdateafter.png)
<p align="center"> Figure 33. After Update Method </p>

## Delete Method
- This method is used to delete a vehicle according to the parameters taken from body to the list.
- If a vehicle instance not on the list is tried to be deleted, the program transmits the required message.

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicledeletebefore.png)
<p align="center"> Figure 34. Before Delete Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicledelete.png)
<p align="center"> Figure 35. Delete Method </p>

![](https://github.com/195-Patika-Dev-Paycore-Net-Bootcamp/assignment-3-berkdemirciogluu/blob/master/images/vehicledeleteafter.png)
<p align="center"> Figure 36. After Delete Method </p>
