﻿using Apttus.Assignment.MovieTicket.Enum;

namespace Apttus.Assignment.MovieTicket
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
    }
}