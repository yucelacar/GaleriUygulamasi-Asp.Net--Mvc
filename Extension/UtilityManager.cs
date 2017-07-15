﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GaleriUygulamasi.Extension
{
    public class UtilityManager
    {
        static string[] dosyaTipleri = { "excel", "pdf", "word", "image", "text", "audio", "video" };
        static string[] dosyaIkonlari = { "glyphicon glyphicon-book", "glyphicon glyphicon-text-width", "glyphicon glyphicon-print", "glyphicon glyphicon-picture", "glyphicon glyphicon-italic", "glyphicon glyphicon-volume-up", "glyphicon glyphicon-play-circle" };

        static string[] dosyaResimleri = { "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAHoAAAB6CAMAAABHh7fWAAAAnFBMVEX///8IdDtDREAAbzI/QDzS4Nfg6+UAZx/D2cxra2kAYxUAcjeBpYiOs5r6/PtyoYNBhVg6Ozby8vKOj40pKiTU1NN8pYbj4+NPUE3Ozs4wMSw1NjEAbCs1Uz88Sz8AaSV5eXdnmniqqqmzs7KFhYNbW1icnJu/v75iY2AtfUlQjmXs8u6jw6+vyrhdlG8AYABVZFgvQTNTblwlRzADqGzAAAAEz0lEQVRoge2bC3OiMBDHMcSqpcXy8FHgDqpYteo9v/93O7QCm0AeJKF25vqf6UwHMD+zyW52JbEsgRavG6QkPBE1LQBnkadGRijOdchbrAwuFL1qkGOsQS76vVYlP8da4ELesxrZR3p9LoS9hRI60O50wca+AtkNQQtxFHZQVH/S2yig13ENzlbPQLPZ7PzH1hb0W8XFstKvvN2s40cXcJIouFhlsknn4SLQKOrsYpW9u08UEo3iji7mX+eKSlig0Cju5mLuFR0qeAeNxl6nRq5orOIcNBrhpauAVln6GmgUZzdDd3Ixw+guLmYajaLtzdAolg2K5tHSq5h5tLSL9YAulgO5z/eARlEAHxuz9PfbRX+YD7B0YKNRuALoEUvOVcwHGLofctAoBC42MC2bi4Yr6EejMVrcCl24mH8rdJHr3QyNopxAO7a2nArtc8mVi13J+0dtPTkl2toISqZwDdBPCkGL0tSu0MKa6eJiJbpL8iREz0Toi4v1gnZ3oiL17GK9oK1tJEAjL+8JXVdszG5P+kILfxfoD20tBL/D9Ii2FkvuNO8Tbfl5zBnwXtGFe2c48vDZ8Bfjv/+DuWjia/C+E3GviS6svg12S1o89HFUrybO6Ajbn6fw1lyEbtMs5Bn8JakXQSe5q2+MU7A8Jm9Ek7LoZy76sHdqgv2juu4OwHVnf+gBbQ1BtwfJqbKGDS6PKIYhtHUElnUG1+6N7yH5SDVpCm29gQ4mL5dLB6d9GLqiIwH6AE3+btspnHyDhtPJorciNGFdx6EuDOC0N462HkEnk0frAGd3emo2aRBtPYHhTofQ15N582mj6DvQT2cPrG2/tUVXk2jrRHhY/a/dHOgO6LUM2prDaV5pNG5tUhody6BdGFDBlPsAtHU3apBtVrVgGG2daHYVVZXRK0k0uWKcl1Bmy8bR1HAn9KKhgPZkc7MhRNtTdpPm0WPT6FdZ9CEhDD5ieFYP6IZnJ+3xpAf0lI5n+s4liT72EFLk0ETuW5lcM5BKoeGqCXSvt3zIoF2YK9jgW7RkR4bRMC9Jp8Rw66QKgRh9BOQi9YWZuVaCJEaPweR2bJcygkZaKEQT+X56nlhEquY0AbLoXIB2ierjsWEHe69cAojQczCydlnMwtBmv/SEhlEMhE7o58rlHh89hqlJWkeQIYxuqkUuF01U9imMm7AYUi3tM8xBE1GMrDRaal+T6DnxSwrZNSKsEwYxgT7BYraxVBDZcQrv6qOHP8H7jLQZMV9SeB/YRBvtPsyBHpqh3YX358DksugJb5qp6Qv9habk3hC9+y/Rm0+E1iarogeDB22Bl8hc9JJGm3x1LkAjCm1Mnxjtoy/0x6Jxib5nqdz+xHyAoZ8itFei71j6/f2iX8wHWBLExRrN1PvbZ7xjP6EmaTRaGkfHsuhQf12h0KEsWn7nqaTW4k2L15f9ODOM3mEhutzCFJrt9ioSdyko9zjgrqcQeKrOVXicrdPVQxitVM6NtGmRVxtGYo4x/frISbzM8jzQVj7x6t0i3D36YBsRxp4Jgf05XsazjnDTmI4EO7bz/tjk5uGW0V5qn6piKJ6IYuRC/0RXq6Kd2GUEu6fUhKNAxln9PNY8v0dzvXgjGx5nwdKIY13daxN0OmvkmxNs9h9+yKEKJEiKNQAAAABJRU5ErkJggg==", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAHgAAAB4CAMAAAAOusbgAAAAYFBMVEX///8AAADq6uqgoKDa2trz8/PDw8P29vYoKCglJSVdXV3f398cHBySkpLQ0NCMjIyFhYVWVlavr6+np6dCQkK6uroRERF6eno5OTlmZmbJyckWFhZycnIuLi5OTk5HR0c9ZU3JAAADdElEQVRoge3b2cKiIBgGYFHBzDDXXNru/y6n7AdFP8QFcQ58j2YKeX4TEFEtaxA7uqCluSfD+qYmXKw2WS7f1sGoXuiSlS5C7jLY+W77Oi/J6wf79nI4WLSp+7fLb7wYXvZr8WZ53gtGj71gdN0LRule8PzurAueXYc2eG531gajbF531gejai94XnfWCc/qzlph5OwFI7IXPL0q3fBtanfWDaPS2wmeenbWD6NiL3had94CnnR23gRG+V4wUneqjWD1j70CDkZg9aC9Av5tuwdseTaQ2gAMxj3gAz7gA94Q/ox4mH6L1dDQtzTNkEmxbctmfaQqT6fT/VvMP2mM/63x/vlHWYFX68XISU1bgHnfw4QLXEDWZtzh2khlCu5frZtyERJdbA7GMvhWnh8RdXLySZ46RewL2z3jqrhSJ/1+nyc0qt7Duh8REHYwpfC1389x/WgXzy9e/2vPzh93EQYn0UQFU2CjgLe9C1SnZVOBBled8yWwZdFR+EPHG8FsYJPB7Z+mG7ZKBWwlmuCQRkXkhLxIKMJ54tA0CbuVOKPw5MYV/f5b8iZadmGbFS86StWD49ulzX0qfGXNickUhLvHhl21cRgBmQzzhQQigTvDb6QVjv8+cGVwu8+BVjjzVHDbmrIt9jiUw5H4W2uCWa25HD5Z3TK6YNaqCzmMWH8OBBg4cc2A+VzlOQLnwscMxm08fpdWCTfdtoz4+CGOXD2Y3a72BLgbviSkhL0gCOxOqXgM5qtJGuBeUjQFxtphdohmHWMNMD/xSGDWAl29MGn7BQzz9X+xH+dJGz5PmArjmnYfC4HhjJUWR64XAqKEnXdVxVlv/iiBeaPWOlarYR+LnxqD+dMu1CzMbzlg3yjctkbW6YzA73aiyRfKt4Txp7n7WZF0LpO8zAQM5MwLGYVxZ7QwCZPuY2Dm4FBcQlkHU2grAPbstA/MgL32i8INv3HhBbcbCe3PDOoXjMO0AGrPw1/AyV5vRSGDyshzKrOy9NXlhslEd+xeld4MlnGfZtznoI3YpQm3BBaEMN18p58Ufu4Iu4TUTWNOicY0E+OiJsQdfdypKbbs8UhJmpPWpvePJfmfb4Yc8AEf8AEf8AEf8AHvCIeexoQz4IuvMZcZsP6o4fUvWoGZ8GT52lfLwNzU7tqX6eCEanfd64NgLgVwjfgP/4ZDbU8NFR0AAAAASUVORK5CYII=", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAHkAAAB5CAMAAAAqJH57AAAAclBMVEUqVpb///8OSZAUS5EAPYqvutG/x9kjUpRRcaWjr8rk5+4ARY4eUJMZTZKClLno7PIAOYmNnr/z9PjT2eVyibHb4OoAQYwzXJmbqsemtM14jra4wtb5+vyRo8JDZ6DEzd0ALoRXeasAEnxhfq0AM4ZqhbG7zyUjAAAEZUlEQVRoge2ai3ajIBCGFWPwAjHRWO+6rpv3f8UdQFO1CRtaseds+U/aU6P1y8DPDBgs97tkoe+SZWRkZGT0k4QJJVa2OxO9na2hcRN3r7qDiYNI5t0aN7W5juEOUIpo1gKzi+LanqSVjDFBiFrtqUqC+p2plwxxhlY7XNwusB9rczLESSlu+9JN0ngdpy4yMB2a9aXfpZEEuSkZjBsecH/yuyD+N3NDMrRtU0UfPKSbjNskejnQJdl5QRQ/J3ufwHIyKfwX1D5Ff54cvnRd+vZd5OBgyIZsyK+SqVs8Vz7lRR1kWfakv1KdZJkOWskhQo9eIbyQ1pidNJFoqrn/l7cNWRu5TrpjVfjv86ZjiOxaoi+Qg+7oFs000a/OCEbM7Np/zMPURlXsunl+GVmxhxxKD+54znfgWnJakGVSyyQpJoSGx/E/+AKZNuO5kjCyuyATif4okesM5omkGO/M54z4Jjqs7tkhTuZkcro+1xCpkG12+6lFc4efbYWnomx2MJK39HYDNDyIv2+En85EmAlv7GF2x23JzDW4Fe07PoxwRLd3zE/0oo2c8ne4ueOzOI1yfiZnH+Rt1s0bk2O2FAmTe5DvLXwl98+khVzfGJm3b06nC/gZD7Mr5ys/8HZzea6Tmre5xfgQrlmQLTM0YQOTD+55HuGeoBKpjWfIkdDGpGTtDkGShkVKWRMkbDQ7xYosk+psKIE2xj2YO4UgUcJGFmUW69jgRsmKvF3ehlD5W9BFR/AyiXz2+zr1OomXZBQHEqnOhlj7hinvcNzayTS+WfBwvCRvW59ZYXjrOAr3djA1Ae/whcE2JxcOTx5sYIPHa0aE7o2ZtdFRK7mDDqUlT9NOJ5oAFXbKuhkvDLY5OSK8ZjCDWdDdBeKt3KFVobLFbCiWSJVsQ4kGxoUKZ3GLDbUPMZObvSJbZ4l+K68xrgDJIo8IErdYFp3IvXTMyTKpr6v4fKsDgyGesYTFhimXLclbZk/In6wolfCDOnZ44xZrWeTBmrxpxRhrQ3YnFTydWutCZWuY6bNSId7m6a+biuUqj2gg12IOAOmakwMyXrYsVDrIvEQz0ji1zsYHpnev6iNXYuoXduJwnIJa5/UdtydH4srDaKhCfJBVobLFTF+iq7K37VoEicbD0WL3Vc6MLF3dnD/xnKQPKcF0mtSL5ZVFqgdkmT7zbKi6XG9eO63dYs8hGGNrbbDtc9jY5PeFd12dyt7L1nlEQ616rAff6/yA5ySGzMmojiTSSbbOh+dSnw2pkGXS+5QZbbiuUiJTV/J1ZK5eMV4n/8RRZciG/LPJOvYZfHlvRZtGantYJvJX95PAqrEdTkUn3Z70mPx18T12h2y4FArbabbcK0UoRYTHn74Q//b7w4BPLG84VUkq3cOkaU8cxjRElndtquRZ8+vdBwj9j4jVX6rko/132vuIW6/0q4X/9iCPeMfBmVfm1Y77Ped86P/DObv6VbrbHtcFn0Bm2nlfr5GRkZGR0U76C4hKffCKHnlrAAAAAElFTkSuQmCC", "data:image/jpeg;base64,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", "data:image/png;base64,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", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThKkuF4oGKXrVPIivgCdOuztlXJWrQgIa48Pe7hiLD8bqQytNn", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9yG3HeYlmRmESknlpMBFeEQZKd-eL_tmIUBeSOfEWcU-OWaVzc_gwIQ" };

        public static byte[] ByteBirlestir(byte[] array1, byte[] array2)
        {
            byte[] outputBytes = new byte[array1.Length + array2.Length];
            Buffer.BlockCopy(array1, 0, outputBytes, 0, array2.Length);
            Buffer.BlockCopy(array2, 0, outputBytes, array1.Length, array2.Length);
            return outputBytes;
        }

        public static string setIcon(string contentType)
        {
            for (int i = 0; i < dosyaTipleri.Length; i++)
            {
                if (contentType.Contains(dosyaTipleri[i]))
                {
                    return dosyaIkonlari[i];
                }
            }
            return "glyphicon glyphicon-paperclip";
        }

        public static string setImage(string contentType)
        {
            for (int i = 0; i < dosyaTipleri.Length; i++)
            {
                if (contentType.Contains(dosyaTipleri[i]))
                {
                    return dosyaResimleri[i];
                }
            }
            return "http://www.free-icons-download.net/images/page-icon-73982.png";
        }

        public static string BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }
}