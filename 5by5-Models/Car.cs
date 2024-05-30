namespace _5by5_Models
{
    public class Car
    {
        public static readonly string INSERT = "INSERT INTO CAR (CAR_NAME, COLOR, CAR_YEAR) VALUES (@CAR_NAME, @COLOR, @CAR_YEAR)";
        public static readonly string UPDATE = "UPDATE CAR SET CAR_NAME = @CAR_NAME, COLOR = @COLOR, CAR_YEAR = @CAR_YEAR WHERE ID = @ID";
        public static readonly string GET = "SELECT ID, CAR_NAME, COLOR, CAR_YEAR FROM CAR WHERE ID = @ID";
        public static readonly string GETALL = "SELECT ID, CAR_NAME, COLOR, CAR_YEAR FROM CAR";
        public static readonly string DELETE = "DELETE FROM CAR WHERE ID = @ID";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public override string ToString() => $"Id: {Id}, Nome: {Name}, Cor: {Color}, Ano: {Year}";
    }
}
