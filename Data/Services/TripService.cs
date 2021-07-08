using building_react_and_asp_dot_net_core_applications.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace building_react_and_asp_dot_net_core_applications.Data.Services
{
    public class TripService : ITripService
    {
        public void AddTrip(Trip trip)
        {
            Data.Trips.Add(trip);
        }

        public void DeleteTrip(int tripId)
        {
            var trip = Data.Trips.FirstOrDefault(x => x.Id == tripId);
            if (trip != null) {
                Data.Trips.Remove(trip);
            }
        }

        public List<Trip> GetAllTrips() => Data.Trips.ToList();

        public Trip GetTripById(int tripId) => Data.Trips.FirstOrDefault(x => x.Id == tripId);

        public void UpdateTrip(int tripId, Trip trip)
        {
            var oldTrip = Data.Trips.FirstOrDefault(x => x.Id == tripId);
            if (oldTrip != null) {
                oldTrip.Name = trip.Name;
                oldTrip.Description = trip.Description;
                oldTrip.DateStarted = trip.DateStarted;
                oldTrip.DateCompleted = trip.DateCompleted;
            }
        }
    }
}
