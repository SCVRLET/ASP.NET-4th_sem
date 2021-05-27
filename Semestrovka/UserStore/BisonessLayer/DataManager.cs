using BisonessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer
{
    public class DataManager
    {
        private IEFPostsRepository _postsRepository;

        public DataManager(IEFPostsRepository postsRepository)
        {
            _postsRepository = postsRepository;
        }


        public IEFPostsRepository Posts { get { return _postsRepository; } }
    }
}
