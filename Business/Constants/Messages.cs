﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string CarAdded = " Araç kayıt işlemi başarılı ";
        public static string CarDeleted = " Araç silme işlemi başarılı ";
        public static string CarUpdated = " Araç güncelleme işlemi başarılı ";
        public static string CarListed = "Arabalar listelendi";

       
        public static string RentalAdded = " Kiralama işlemi başarılı ";
        public static string RentaUpdated = " Kiralık güncelleme işlemi başarılı ";
        public static string RentalDeleted = " Kiralık araç silme işlemi başarılı ";


        public static string CustomerUpdated = "Müşteri guncelleme işlemi başarılı ";
        public static string CustomerDeleted = " Müşteri silme işlemi başarılı ";
        public static string CustomerAdded = "Müşteri ekleme işlemi başarılı ";
        public static string CustomerListed = "Müşteriler listelendi";
       
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserAdded = "Kullanıcı ekleme işlemi başarılı";
        public static string UserDeleted = "Kullanıcı silme işlemi başarılı";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        
        
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImagesCorrectErrors = "Araba resmi yüklenmiyor";
        public static string CarImagesDeleted = "Araç resimleri silindi!";
        public static string CarImageNotFound = "Araç resmi bulunamadı!";
        public static string CarImageCountExceeded = "Bir araca maksimum 5 resim eklenebilir!";


        public static string AuthorizationDenied = "Yetkin yok.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string AccessTokenCreated = "Token oluşturuldu.";  
        public static string MaintenanceTime = "Sistem bakımda";
       
        public static string GetSuccessCarMessage = "Araç bilgisi / bilgileri getirildi.";
        public static string GetErrorCarMessage = "Araç bilgisi / bilgileri getirilemedi.";

       
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDelete = "Marka silindii..";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandUpdated = " Marka kayıt işlemi başarılı ";
        public static string BrandAddError = " Eklemek istediğiniz marka zaten mevcut.Farklı bir renk giriniz. ";

        public static string ColorDeleted = "Renginiz silindi";
        public static string ColorUpdated = "Renginiz güncellendi";
        public static string ColorAdded = "Renk ekleme işlemi başarılı ";
    }
}
