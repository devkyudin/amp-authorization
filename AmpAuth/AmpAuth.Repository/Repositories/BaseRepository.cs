﻿using AmpAuth.Repository.Interfaces;

namespace AmpAuth.Repository.Repositories
{
	public abstract class BaseRepository
	{
		protected string ConnectionString { get; }
		protected IRepositoryContextFactory ContextFactory { get; }
		public BaseRepository(string connectionString, IRepositoryContextFactory contextFactory)
		{
			ConnectionString = connectionString;
			ContextFactory = contextFactory;
		}
	}
}
