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
            var itemsManager = new ItemsManager();

            var documents = documentsManager.GetAllCFDocuments().CFDocuments;
            var subjects = new HashSet<CFSubject>(EqualityComparers.CFSubject);
            var itemTypes = new HashSet<CFItemType>(EqualityComparers.CFItemType);
            var associations = new List<CFPckgAssociation>();
            var items = new List<CFPckgItem>();

            var itemBag = new Dictionary<CFPckgItem, List<CFPckgAssociation>>();

            var database = new Database("Server=.;Database=CASE_DB;Integrated Security=True");

            database.Clear();

            var documentPackages = new List<DocumentPackage>();

            foreach(var document in documents)
            {
                Logger.Log($"Reading package '{document.Title}'");

                var package = packagesManager.GetCFPackage(document.CFPackageURI.Identifier);

                documentPackages.Add(new DocumentPackage(package));

                foreach(var itemType in package.CFDefinitions.CFItemTypes)
                {
                    itemTypes.Add(itemType);
                }

                foreach (var subject in package.CFDefinitions.CFSubjects)
                {
                    subjects.Add(subject);
                }
            }

            foreach (var subject in subjects)
                database.InsertSubject(subject);

            foreach (var itemType in itemTypes)
                database.InsertItemType(itemType);

            foreach(var documentPackage in documentPackages)
            {
                var document = documentPackage.Document;

                database.InsertDocument(document);

                foreach (var association in documentPackage.Associations)
                    database.InsertAssociation(association);

                foreach (var item in documentPackage.Items)
                    database.InsertItem(item, document.Identifier);

                
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
