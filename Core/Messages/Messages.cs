using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Messages
{
    //In this class, messages that can be used continuously in different parts of the project.
    public static class Messages
    {
        public static string ContainerAdded = "Container added";
        public static string ContainerIdInvalid = "Container id invalid";
        public static string ContainersListed = "Containers listed";
        public static string ContainerUpdated = "Container updated";
        public static string ContainerDeleted = "Container deleted";
        public static string ContainerNotAdded = "Container could not added";
        public static string ContainerNotUpdated = "Container could not updated";
        public static string ContainerNotDeleted = "Container could not deleted";

        public static string VehicleAdded = "Vehicle added";
        public static string VehicleIdInvalid = "Vehicle id invalid";
        public static string VehiclesListed = "Vehicles listed";
        public static string VehicleUpdated = "Vehicle updated";
        public static string VehicleDeleted = "Vehicle deleted and related containers deleted";
        public static string VehicleNotAdded = "Vehicle could not added";
        public static string VehicleNotDeleted = "Vehicle could not deleted";
        public static string VehicleNotUpdated = "Vehicle could not updated";

        public static string NoContainerWithId = "There is no container with the id";
    }
}
