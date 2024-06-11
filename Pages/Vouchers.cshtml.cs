using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace WebStaff.Pages
{
    [Authorize]
    public class VouchersModel : PageModel
    {
        public List<VoucherInfo> VoucherList { get; set; }

        [BindProperty]
        public string VoucherCode { get; set; }

        [BindProperty]
        public int Valuess { get; set; }

        [BindProperty]
        public decimal MinimumPurchaseAmount { get; set; }

        [BindProperty]
        public string Description { get; set; }

        public VouchersModel()
        {
            VoucherList = new List<VoucherInfo>();
        }

        public void OnGet()
        {
            LoadVouchers();
        }

        public IActionResult OnPostAddVoucher()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "INSERT INTO Vouchers (VoucherCode, Valuess, MinimumPurchaseAmount, Description) VALUES (@VoucherCode, @Valuess, @MinimumPurchaseAmount, @Description)";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@VoucherCode", (object)VoucherCode ?? DBNull.Value);
                            command.Parameters.AddWithValue("@Valuess", Valuess);
                            command.Parameters.AddWithValue("@MinimumPurchaseAmount", MinimumPurchaseAmount);
                            command.Parameters.AddWithValue("@Description",Description);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while adding the voucher.", ex);
                }
            }

            LoadVouchers();
            return Page();
        }

        public IActionResult OnPostDeleteVoucher(int voucherId)
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Vouchers WHERE VoucherId = @VoucherId";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@VoucherId", voucherId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the voucher.", ex);
            }

            LoadVouchers();
            return RedirectToPage();
        }

        private void LoadVouchers()
        {
            try
            {
                string connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFoodDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT VoucherId, VoucherCode, Valuess, MinimumPurchaseAmount, Description FROM Vouchers";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            VoucherList.Clear();
                            while (reader.Read())
                            {
                                VoucherInfo voucher = new VoucherInfo
                                {
                                    VoucherId = reader.GetInt32(0),
                                    VoucherCode = reader.GetString(1),
                                    Valuess = reader.GetInt32(2),
                                    MinimumPurchaseAmount = reader.GetDecimal(3),
                                    Description = reader.GetString(4)
                                };

                                VoucherList.Add(voucher);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving data from the database.", ex);
            }
        }
    }

    public class VoucherInfo
    {
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public int Valuess { get; set; }
        public decimal MinimumPurchaseAmount { get; set; }
        public string Description { get; set; }
    }
}
