﻿namespace KMG.Repository.Models.Pay.Config
{
    public class VnPayConfig
    {
        public static string ConfigName => "VnPay";
        public string Version { get; set; }
        public string TmnCode { get; set; } = string.Empty;
        public string HashSecret { get; set; } = string.Empty;
        public string ReturnUrl { get; set; } = string.Empty;
        public string PaymentUrl { get; set; } = string.Empty;
    }
}
