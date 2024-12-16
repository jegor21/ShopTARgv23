﻿using ShopTARgv23.Core.Dto;

namespace ShopTARgv23.Core.ServiceInterface
{
    public interface IEmailsServices
    {
        void SendEmail(EmailDto dto);
        public void SendEmailToken(EmailTokenDto dto, string token);
    }
}