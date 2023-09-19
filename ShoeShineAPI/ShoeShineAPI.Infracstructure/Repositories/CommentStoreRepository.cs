﻿using Microsoft.EntityFrameworkCore;
using ShoeShineAPI.Core.IRepositories;
using ShoeShineAPI.Core.Model;
using ShoeShineAPI.Infracstructure.DatabaseConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShineAPI.Infracstructure.Repositories
{
	public class CommentStoreRepository : GenericRepository<CommentStore>, ICommentStoreRepository
	{
		public CommentStoreRepository(DbContextClass context) : base(context)
		{
		}
		public override async Task<IEnumerable<CommentStore>> GetAll()
		{
			return await _dbContext.Set<CommentStore>()
				.Include(s => s.ImageComments)
				.Include(s => s.RatingComment)
				.Include(s => s.User)
				.Include(s => s.Store)
				.ToListAsync();
		}
		public async Task<IEnumerable<CommentStore>> GetCommentByStoreId(int StoreId)
		{
			return await _dbContext.Set<CommentStore>()
				.Where(x => x.StoreId == StoreId)
				.Include(s => s.ImageComments)
				.Include(s => s.RatingComment)
				.Include(s => s.User)
				.Include(s => s.Store)
				.ToListAsync();
		}
	}
}