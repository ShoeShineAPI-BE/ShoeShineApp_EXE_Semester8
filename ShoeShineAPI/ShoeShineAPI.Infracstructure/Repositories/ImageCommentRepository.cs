﻿using ShoeShineAPI.Core.IRepositories;
using ShoeShineAPI.Core.Model;
using ShoeShineAPI.Infracstructure.DatabaseConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShineAPI.Infracstructure.Repositories
{
	public class ImageCommentRepository : GenericRepository<ImageComment>, IImageCommentRepository
	{
		public ImageCommentRepository(DbContextClass context) : base(context)
		{
		}
	}
}
