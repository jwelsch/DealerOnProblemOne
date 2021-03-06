﻿using System;
using System.IO;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Reads command set data from a file.
    /// </summary>
    public class FileCommandSetReader : ICommandSetReader
    {
        /// <summary>
        /// Path to the file to read.
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="path">Path to the file to read.</param>
        public FileCommandSetReader(string path)
        {
            this.path = path ?? throw new ArgumentNullException(nameof(path));

            if (path.Length == 0)
            {
                throw new ArgumentException("The path is empty.", nameof(path));
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("The file at the path does not exist.", path);
            }
        }

        /// <summary>
        /// Reads the command set to a string.
        /// </summary>
        /// <returns>String containing a command set.</returns>
        public string Read()
        {
            using (var reader = new StreamReader(this.path))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
