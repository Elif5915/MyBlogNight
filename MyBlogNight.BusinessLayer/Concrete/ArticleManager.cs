﻿using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.BusinessLayer.Concrete;
public class ArticleManager : IArticleService
{
	private readonly IArticleDal _articleDal;
	public ArticleManager(IArticleDal articleDal)
	{
		_articleDal = articleDal;
	}

	public List<Article> ArticleListWithCategoryAndAppUser()
	{
		return _articleDal.ArticleListWithCategoryAndAppUser();
	}

	public List<Article> TArticleListWithCategory()
	{
		return _articleDal.ArticleListWithCategory();
	}

	public Article TArticleListWithCategoryAndAppUserByArticleId(int id)
	{
		return _articleDal.ArticleListWithCategoryAndAppUserByArticleId(id);
	}

	public void TArticleViewCountIncrease(int id)
	{
		_articleDal.ArticleViewCountIncrease(id);
	}

	public void TDelete(int id)
	{
		_articleDal.Delete(id);
	}
	public List<Article> TGetAll()
	{
		return _articleDal.GetAll();
	}

	public List<Article> TGetArticlesByAppUserId(int id)
	{
		return _articleDal.GetArticlesByAppUserId(id);
	}

	public Article TGetById(int id)
	{
		return _articleDal.GetById(id);
	}
	public void TInsert(Article entity)
	{
		_articleDal.Insert(entity);
	}
	public void TUpdate(Article entity)
	{
		_articleDal.Update(entity);
	}


}

