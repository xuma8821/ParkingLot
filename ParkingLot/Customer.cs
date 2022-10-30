﻿using System;

namespace ParkingLot
{
    public class Customer
    {
        private string carNum;

        public Customer(string carNum)
        {
            this.CarNum = carNum;
        }

        public string CarNum { get => carNum; set => carNum = value; }

        public Ticket ParkCar(string carNum, ParkingBoy parkingBoy)
        {
            return parkingBoy.HelpParkCar(carNum);
        }

        public bool FetchCar(Ticket ticket, ParkingBoy parkingBoy)
        {
            return parkingBoy.HelpFetchCar(ticket);
        }
    }
}