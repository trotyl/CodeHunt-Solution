﻿using System;
using System.Linq;
public class Program
{
    public static string Puzzle(string s)
    {
        return s + String.Join("", s.Reverse());
    }
}