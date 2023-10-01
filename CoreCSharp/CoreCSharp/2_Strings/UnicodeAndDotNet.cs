using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace CoreCSharp.Strings
{
    public static class UnicodeAndDotNet
    {
        //System.Text.Encoding -> provides facilities for converting arrays of bytes to arrays of characters, or strings
        //System.Char structure -> most basic character type, each char is single UNICODE character and takes 2 bytes in memroy
        //System.String class -> sequence of chars, immutable

        //Character -> a
        //Unicode   -> U+0061
        //UTF-8     -> 61
        //UTF-16    -> 0061

        //Build-in ecoding schemes:
        //ASCII -> only 7 bit
        //UTF-8 -> each character is encoded as a sequence of 1-4 bytes
        //UTF-16 -> is effectively how characters are maintained internally in .NET. Each character is encoded as a sequence of 2 bytes


        //CZECH LANGUAGE unicode ranges:
        //Unicode blocks 0000-007F ("Basic Latin"), 0080-00FF("Latin-1 Supplement"), and 0100-017F ("Latin Extended-A") contain all the characters necessary in written Czech

        public static void BytesVsCharacters(string inputString)
        {
            if(inputString == null) throw new ArgumentNullException(nameof(inputString));

            byte[] bytesFromString = System.Text.Encoding.UTF8.GetBytes(inputString);
            string stringFromBytes = System.Text.Encoding.UTF8.GetString(bytesFromString);
        }

        public static void SeriaizeObjectWithTextInCzech()
        {
            //JsonSerializerOptions needs o be configured like following:

            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Latin1Supplement, UnicodeRanges.LatinExtendedA),
                WriteIndented = true
            };
        }
    }
}
