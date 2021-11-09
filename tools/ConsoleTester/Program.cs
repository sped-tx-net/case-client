// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Ims.Case.Api;
using Ims.Case.Model;
using Ims.Case.Client;

namespace ConsoleTester
{
    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {

            var documentsManager = new DocumentsManager();
            var packagesManager = new PackagesManager();
            var documents = documentsManager.GetAllCFDocuments().CFDocuments;

            foreach(var document in documents)
            {
                var package = packagesManager.GetCFPackage(document.CFPackageURI.Identifier);

                Console.WriteLine($"{document.Identifier,8} {document.Subject,8} ");

                var definitions = package.CFDefinitions;
                var rubrics = package.CFRubrics;
                var associations = package.CFAssociations;
                var items = package.CFItems;
                var itemTypes = package.CFDefinitions.CFItemTypes;
                var subjects = package.CFDefinitions.CFSubjects;

                
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
