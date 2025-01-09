namespace WebApiDemo.Models
{
    public interface IRepository
    {
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);

        IEnumerable<Reservation> Reservations { get; }

        Reservation this[int id] { get;}
    }
}
