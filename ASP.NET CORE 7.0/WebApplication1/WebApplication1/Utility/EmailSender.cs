﻿using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebApplication1.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Ucretli email sunucuları buraya konulacak.
            return Task.CompletedTask;  
        }
    }
}