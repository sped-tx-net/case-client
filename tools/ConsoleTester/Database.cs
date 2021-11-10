using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Ims.Case.Model;

namespace ConsoleTester
{
    internal class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }


        private SqlConnection CreateConnection()
        {
            return new SqlConnection
            {
                ConnectionString = _connectionString,
            };
        }

        public void Clear()
        {
            DeleteData("CFDocument");
            DeleteData("CFAssociation");
            DeleteData("CFItem");
            DeleteData("CFSubject");
            DeleteData("CFItemType");

        }

        public void DeleteData(string tableName)
        {
            Logger.Log($"Clearing table '{tableName}' data...");

            using (SqlConnection connection = CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"DELETE FROM dbo.{tableName}";
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();
                }
            }
        }

        public void InsertItem(CFPckgItem item, string documentId)
        {
            using (SqlConnection connection = CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO dbo.CFItem VALUES (@Id,@DocumentId,@ItemTypeId,@FullStatement,@AlternativeLabel," +
                        "@HumanCodingScheme,@ListEnumeration,@AbbreviatedStatement,@Language," +
                        "@StatusStartDate,@StatusEndDate,@LastChangeDateTime,@Notes)";

                    command.Parameters.AddWithValue("@Id", item.Identifier);
                    command.Parameters.AddWithValue("@DocumentId", documentId);
                    command.Parameters.AddWithValue("@ItemTypeId", item.CFItemTypeURI.Identifier);
                    command.Parameters.AddWithValue("@FullStatement", item.FullStatement);
                    command.Parameters.AddWithValue("@AlternativeLabel", item.AlternativeLabel);
                    command.Parameters.AddWithValue("@HumanCodingScheme", item.HumanCodingScheme);
                    command.Parameters.AddWithValue("@ListEnumeration", item.ListEnumeration);
                    command.Parameters.AddWithValue("@AbbreviatedStatement", item.AbbreviatedStatement);
                    command.Parameters.AddWithValue("@Language", item.Language);
                    command.Parameters.AddWithValue("@StatusStartDate", item.StatusStartDate);
                    command.Parameters.AddWithValue("@StatusEndDate", item.StatusEndDate) ;
                    command.Parameters.AddWithValue("@LastChangeDateTime", item.LastChangeDateTime);
                    command.Parameters.AddWithValue("@Notes", item.Notes);

                    command.SetNull();

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                connection.Close();
            }

            Logger.Log($"Inserted CFItem '{item.HumanCodingScheme}'");
        }


        public void InsertAssociation(CFPckgAssociation association)
        {
            using (SqlConnection connection = CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO dbo.CFAssociation VALUES (@Id,@AssociationType,@SequenceNumber,@OriginNodeId,@DestinationNodeId,@LastChangeDateTime)";

                    command.Parameters.AddWithValue("@Id", association.Identifier);
                    command.Parameters.AddWithValue("@AssociationType", association.AssociationType);
                    command.Parameters.AddWithValue("@SequenceNumber", association.SequenceNumber);
                    command.Parameters.AddWithValue("@OriginNodeId", association.OriginNodeURI.Identifier);
                    command.Parameters.AddWithValue("@DestinationNodeId", association.DestinationNodeURI.Identifier);
                    command.Parameters.AddWithValue("@LastChangeDateTime", association.LastChangeDateTime);

                    command.SetNull();

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                connection.Close();
            }

            Logger.Log($"Inserted CFAssociation '{association.Identifier}' with type '{association.AssociationType}'");
        }

        public void InsertItemType(CFItemType itemType)
        {
            using (SqlConnection connection = CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO dbo.CFItemType VALUES (@Id,@Title,@Description,@HierarchyCode,@TypeCode,@LastChangeDateTime)";

                    command.Parameters.AddWithValue("@Id", itemType.Identifier);
                    command.Parameters.AddWithValue("@Title", itemType.Title);
                    command.Parameters.AddWithValue("@Description", itemType.Description);
                    command.Parameters.AddWithValue("@HierarchyCode", itemType.HierarchyCode);

                    command.Parameters.AddWithValue("@TypeCode", itemType.TypeCode);

                    command.Parameters.AddWithValue("@LastChangeDateTime", itemType.LastChangeDateTime);

                    command.SetNull();

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                connection.Close();
            }

            Logger.Log($"Inserted CFItemType '{itemType.Title}'");
        }

        public void InsertSubject(CFSubject subject)
        {
            using (SqlConnection connection = CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO dbo.CFSubject VALUES (@Id,@Title,@HeirarchyCode,@Description,@LastChangeDateTime)";

                    command.Parameters.AddWithValue("@Id", subject.Identifier);
                    command.Parameters.AddWithValue("@Title", subject.Title);
                    command.Parameters.AddWithValue("@HeirarchyCode", subject.HierarchyCode);
                    command.Parameters.AddWithValue("@Description", subject.Description);
                    command.Parameters.AddWithValue("@LastChangeDateTime", subject.LastChangeDateTime);

                    command.SetNull();

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                connection.Close();
            }

            Logger.Log($"Inserted CFSubject '{subject.Title}'");
        }


        public void InsertDocument(CFPckgDocument document)
        {
            using (SqlConnection connection = CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        "INSERT INTO dbo.CFDocument VALUES " +
                        "(@Id,@SubjectId,@LicenseId,@Creator,@OfficialSourceURL,@Title,@Publisher,@Description,@Version,@AdoptionStatus,@Language," +
                        "@StatusStartDate,@StatusEndDate,@LastChangeDateTime,@Notes)";

                    command.Parameters.AddWithValue("@Id", document.Identifier);
                    command.Parameters.AddWithValue("@SubjectId", document.SubjectURI[0].Identifier);
                    command.Parameters.AddWithValue("@LicenseId", null);
                    command.Parameters.AddWithValue("@Creator", document.Creator);
                    command.Parameters.AddWithValue("@OfficialSourceURL", document.OfficialSourceURL);
                    command.Parameters.AddWithValue("@Title", document.Title);
                    command.Parameters.AddWithValue("@Publisher", document.Publisher);
                    command.Parameters.AddWithValue("@Description", document.Description);
                    command.Parameters.AddWithValue("@Version", document.Version);
                    command.Parameters.AddWithValue("@AdoptionStatus", document.AdoptionStatus);
                    command.Parameters.AddWithValue("@Language", document.Language);
                    command.Parameters.AddWithValue("@StatusStartDate", document.StatusStartDate);
                    command.Parameters.AddWithValue("@StatusEndDate", document.StatusEndDate);
                    command.Parameters.AddWithValue("@LastChangeDateTime", document.LastChangeDateTime);
                    command.Parameters.AddWithValue("@Notes", document.Notes);

                    command.SetNull();

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                connection.Close();
            }

            Logger.Log($"Inserted CFDocument '{document.Title}'");
        }
    }

    internal static class SqlCommandExtensions
    {
        public static void SetNull(this SqlCommand source)
        {
            foreach (SqlParameter parameter in source.Parameters)
            {
                if (parameter.Value == null)
                    parameter.Value = DBNull.Value;
            }
        }
    }


    public class DocumentPackage
    {
        public DocumentPackage(CFPackage package)
        {
            Items = package.CFItems;
            Document = package.CFDocument;
            Associations = package.CFAssociations;
        }

        public CFPckgDocument Document { get; set; }

        public List<CFPckgItem> Items { get; set; }

        public List<CFPckgAssociation> Associations { get; set; }
    }
}
