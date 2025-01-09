
namespace WebApiDemo.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, Reservation > items;
        public Repository() {
            items = new Dictionary<int, Reservation>();
            new List<Reservation>() { 
             new Reservation{Id=1,Name="Rupesh",StartLocation="Ongole",EndLocation="Chennai"},
             new Reservation{Id=2,Name="Narasimha",StartLocation="chennai",EndLocation="venkatagiri" },
             new Reservation{Id=3,Name="Vinay",StartLocation="Nellore",EndLocation="Bangalore" }
            
            }.ForEach(r=> AddReservation(r));
        }
        public Reservation this[int id] => items.ContainsKey(id)? items[id]:null;

        //get all the list items
        public IEnumerable<Reservation> Reservations => items.Values;

        public Reservation AddReservation(Reservation reservation)
        {
            if (reservation.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reservation.Id = key;
            }
            items[reservation.Id] = reservation;
            return reservation;
        }

        public void DeleteReservation(int id)
        {
            items.Remove(id);
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
           return  AddReservation(reservation);
        }
    }
}
