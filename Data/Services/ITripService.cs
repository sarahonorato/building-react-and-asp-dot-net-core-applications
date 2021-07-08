using building_react_and_asp_dot_net_core_applications.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace building_react_and_asp_dot_net_core_applications.Data.Services
{
    public interface ITripService
    {
        List<Trip> GetAllTrips();
        Trip GetTripById(int tripId);
        void UpdateTrip(int tripId, Trip trip);
        void DeleteTrip(int tripId);
        void AddTrip(Trip trip);
    }
}
