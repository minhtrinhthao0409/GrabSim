using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabSim.BackEnd.Trip
{
    class TripHandler
    {
    //Chức năng chính: tạo ra trip mới và tính toán tất cả

        //private List<Driver> activeDriverNearBy;
        //private GeoService geoService;
        public Trip CreateTrip(string pickup, string startLocation, string endLocation, string paymentMethod)
        {
            /*
        // tripId: int
            int tripId = this.GeneratesID();
            // startLocation: string (Lấy từ API vào)
            string startLocation = "";
            // endLocation: string (Lấy từ API vào)
            string endLocation = "";
            // distance: float
            float distance = this.EstimateDistance();
            // price: float
            float price = this.EstimateFare();
            // status: bool
            bool status = true; // true: chưa hoàn thành, false: đã hoàn thành
            // date: DateTime
            DateTime date = DateTime.Now;
            // driverID: string
            string driverID = this.SearchDriver();
            // customerID: string
            string customerID = "Don't know how to do it";
            //- paymentMethod: string
            string paymentMethod = "Don't know how to do it";
            return new Trip(tripID,startLocation,endLocation,distance,price,status, date, driverID, customerID,paymentMethod);
        */
        
        //Ví dụ có một List of Drivers vào, viết một hàm chọn 1
        public Driver SearchDriver(List<Driver> drivers)
        {
            //Chọn driver trong bán kính r, rồi sau đó tăng r lên 1000 cho đến khi tìm thấy
            int r = 1000;
            while (true)
            {
                foreach (Driver driver in drivers)
                {
                    if (driver.DistanceToCustomer < r)
                    {
                        return driver;
                    }
                }
                r += 1000;
            }
        }

        // sửa lại thành int
        public int GeneratesID()
        {
            string timestamp = DateTime.UtcNow.Ticks.ToString();
            string random = new Random().Next(1000, 9999).ToString();
            return int.Parse(timestamp + random);
        }
        //sửa thành float
        public float EstimateDistance()
        {
            return 0;
        }
        //sửa thành float
        public float EstimateFare()
        {
            return 0;
        }
    }
}
