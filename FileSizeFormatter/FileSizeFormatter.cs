using System;
using System.Collections.Generic;
using System.Text;

    public class FileSizeFormatter
        {
        private static readonly string[] SizeSuffixes =
                ["B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"];

        private static readonly string[] SizeSuffixesInternet =
                ["b", "Kb", "Mb", "Gb", "Tb", "Pb", "Eb", "Zb", "Yb"];

        private static string FormatSizeCommon(long size , string [] suffixes)
            {
            var index = 0;
            double formattedSize = size;

            while (formattedSize >= 1024 && index < suffixes.Length - 1)
                {
                formattedSize /= 1024;
                index++;
                }

            return $"{formattedSize:N1} {suffixes [index]}";
            }

        public static string FormatSize(long size) => FormatSizeCommon(size , SizeSuffixes);

        public static string FormatSizeInternet(long size) => FormatSizeCommon(size * 8 , SizeSuffixesInternet);
        }
