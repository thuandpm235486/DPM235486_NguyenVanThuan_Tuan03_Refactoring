using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_State_Strategy
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceTypeCodeWithStateStrategy_Real
    {
        // Ung dung: trang thai phong khach san co the chuyen doi
        public abstract class RoomState { public abstract string GetStatus(); public abstract double GetRate(); }
        public class AvailableState  : RoomState { public override string GetStatus() { return "Co phong"; } public override double GetRate() { return 800000; } }
        public class OccupiedState   : RoomState { public override string GetStatus() { return "Da co khach"; } public override double GetRate() { return 0; } }
        public class MaintenanceState: RoomState { public override string GetStatus() { return "Dang bao tri"; } public override double GetRate() { return 0; } }
        public class HotelRoom
        {
            public string Number { get; set; }
            public RoomState State { get; set; }
        }
        public void Run()
        {
            var room = new HotelRoom { Number = "101", State = new AvailableState() };
            Console.WriteLine("Room " + room.Number + ": " + room.State.GetStatus() + " - " + room.State.GetRate().ToString("N0") + " VND/night");
            room.State = new OccupiedState();
            Console.WriteLine("Room " + room.Number + ": " + room.State.GetStatus());
        }
    }
}