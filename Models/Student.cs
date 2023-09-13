﻿namespace WebApplication_baiTap.Models
{
    public class Student
    {
        public int Id { get; set; }// mã sinh viên
        public string? Name { get; set; }// họ tên
        public string? Email { get; set; }// Email
        public string? Password { get; set; }// Mật khẩu
        public Branch? Branch { get; set; }// ngành học
        public Gender? Gender { get; set; }// Giới tính
        public bool IsRegular { get; set; }//Hệ:true-chính quy, false-phi chính quy
        public string? Address { get; set; }//Địa chỉ
        public DateTime DateOfBorth { get; set; }//Ngày sinh
    }
}
