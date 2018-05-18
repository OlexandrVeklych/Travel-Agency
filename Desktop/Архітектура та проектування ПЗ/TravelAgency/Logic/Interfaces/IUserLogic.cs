﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DTOs;

namespace Logic
{
    public interface IUserLogic
    {
        void AddUser(UserDTO NewUser);
        IEnumerable<UserDTO> GetAllUsers();
        UserDTO GetUser(int Id);
        void DeleteUser(int Id);
        void EditUser(int Id, UserDTO User);
        UserDTO Enter(string Login, string Password);
        void ReserveTour(int UserId, int TourId);
        void ReserveRoom(int UserId, int HotelId, int HotelRoomId);
        void ReserveTicket(int UserId, int TransportId, int SeatNumber);

    }
}
