namespace API.Entities
{
    public class AppFlights
    {
        public int Id { get; set; }

        public string ciudadOrigen { get; set; }

        public string ciudadDestino { get; set; }

        public string fecha { get; set; }

        public int horaSalida { get; set; }

        public int horaLlegada { get; set; }

        public int numeroDeVuelo { get; set; }

        public string aerolinea { get; set; }

        public string estadoDelVuelo { get; set; }
    }
}