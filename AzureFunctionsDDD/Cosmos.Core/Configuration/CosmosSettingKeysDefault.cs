using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctionsDDD.Cosmos.Core.Configuration
{
    public static partial class CosmosSettingKeysDefault
    {
        /// <summary>
        /// Gets a default key name for AzureCloudStorageAcccount BlobConnectionString
        /// </summary>
        public static string AzureCloudStorageAccBlobConnectionStringKey => "BlobConnectionString";

        /// Gets App Enviroment key
		/// </summary>
		public static string AppEnviromentStringKey => "Environment";

        /// Gets Mssql connection String key
        /// </summary>
        public static string MsSqlConnectionStringKey => "CosmosDBConnection";
        
    }
}
