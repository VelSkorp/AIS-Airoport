﻿using System.Threading.Tasks;

namespace AIS_Airoport.Core
{
	/// <summary>
	/// Stores and retrieves information about the client application 
	/// such as login credentials and so on
	/// </summary>
	public interface IDataStore
	{
		/// <summary>
		/// Determines if the current user has logged in credentials
		/// </summary>
		Task<bool> HasCredentialsAsync();

		/// <summary>
		/// Makes sure the client data store is correctly set up
		/// </summary>
		/// <returns>Returns a task that will finish once setup is complete</returns>
		Task EnsureDataStoreAsync();

		/// <summary>
		/// Gets the stored login credentials for this client
		/// </summary>
		/// <returns>Returns the login credentials if they exist, or null if none exist</returns>
		Task<LoginCredentialsDataModel> GetLoginCredentialsAsync();

		/// <summary>
		/// Stores the given login credentials to the backing data store
		/// </summary>
		/// <param name="loginCredentials">The login credentials to save</param>
		/// <returns>Returns a task that will finish once the save is complete</returns>
		Task SaveLoginCredentialsAsync(LoginCredentialsDataModel loginCredentials);
	}
}