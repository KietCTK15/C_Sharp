﻿using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Repositories;
using Repositories.Models;
using Services;

namespace TesterDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookServices bookServices = new BookServices();
        }
    }
}
