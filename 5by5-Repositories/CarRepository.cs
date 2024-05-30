using _5by5_Models;
using Microsoft.Data.SqlClient;
using System.Text;

namespace _5by5_Repositories
{
    public class CarRepository
    {
        string strConn = "Data Source = 127.0.0.1; Initial Catalog=5by5-ProjAula2Andre; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public CarRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Car car)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new(Car.INSERT, conn);
                cmd.Parameters.Add(new SqlParameter("@CAR_NAME", car.Name));
                cmd.Parameters.Add(new SqlParameter("@COLOR", car.Color));
                cmd.Parameters.Add(new SqlParameter("@CAR_YEAR", car.Year));

                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                return result;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public bool Update(Car car)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new(Car.UPDATE, conn);
                cmd.Parameters.Add(new SqlParameter("@ID", car.Id));
                cmd.Parameters.Add(new SqlParameter("@CAR_NAME", car.Name));
                cmd.Parameters.Add(new SqlParameter("@COLOR", car.Color));
                cmd.Parameters.Add(new SqlParameter("@CAR_YEAR", car.Year));

                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                return result;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new(Car.DELETE, conn);

                cmd.Parameters.Add(new SqlParameter("@ID", id));

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return result;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<Car> GetAll()
        {
            List<Car> cars = new();
            try
            {
                SqlCommand cmd = new(Car.GETALL, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Car car = new Car();
                    car.Id = reader.GetInt32(0);
                    car.Name = reader.GetString(1);
                    car.Color = reader.GetString(2);
                    car.Year = reader.GetInt32(3);
                    cars.Add(car);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return cars;
        }

        public Car Get(int id)
        {
            Car car = new();
            try
            {
                SqlCommand cmd = new(Car.GET, conn);
                cmd.Parameters.Add(new("@ID", id));
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    car.Id = reader.GetInt32(0);
                    car.Name = reader.GetString(1);
                    car.Color = reader.GetString(2);
                    car.Year = reader.GetInt32(3);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return car;
        }
    }
}
