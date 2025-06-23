using System;
using System.Collections.Generic;

class Program
{
    // Enum nama-nama bulan untuk memperjelas input dan mapping
    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    static void Main()
    {
        // Dictionary sebagai table-driven method yang menghubungkan enum dengan jumlah hari
        Dictionary<Months, int> daysInMonth = new Dictionary<Months, int>()
        {
            { Months.January, 31 },
            { Months.February, 28 }, // Tahun non-kabisat
            { Months.March, 31 },
            { Months.April, 30 },
            { Months.May, 31 },
            { Months.June, 30 },
            { Months.July, 31 },
            { Months.August, 31 },
            { Months.September, 30 },
            { Months.October, 31 },
            { Months.November, 30 },
            { Months.December, 31 }
        };

        Console.Write("Masukkan nomor bulan (1-12): ");
        if (int.TryParse(Console.ReadLine(), out int inputMonth))
        {
            if (Enum.IsDefined(typeof(Months), inputMonth))
            {
                Months month = (Months)inputMonth;
                int days = daysInMonth[month];
                Console.WriteLine($"Jumlah hari dalam bulan {month} adalah {days} hari.");
            }
            else
            {
                Console.WriteLine("Bulan tidak valid. Masukkan angka antara 1 sampai 12.");
            }
        }
        else
        {
            Console.WriteLine("Input bukan angka yang valid.");
        }
    }
}
