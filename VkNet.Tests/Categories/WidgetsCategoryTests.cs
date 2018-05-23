﻿using NUnit.Framework;
using VkNet.Model.RequestParams;

namespace VkNet.Tests.Categories
{
	[TestFixture]
	public class WidgetsCategoryTests: BaseTest
	{
		[Test]
		public void GetComments()
		{
			Url = "https://api.vk.com/method/widgets.getComments";
			Json =
				@"{
					""response"": {
						""count"": 10,
						""posts"": [
							{
								""id"": 292,
								""from_id"": 459911423,
								""to_id"": 459911423,
								""date"": 1520738708,
								""post_type"": ""post"",
								""text"": ""&#10084;&#10084;&#10084;"",
								""post_source"": {
									""link"": {
										""url"": ""http://griffiny.r...smerti-est-ten.html"",
										""title"": ""1 сезон 1 серия: И у Смерти есть тень"",
										""description"": ""Первая серия Гриффинов, в которой Питера уволили с работы, и вся семья жила на огромное пособие по безработице.""
									},
									""type"": ""widget"",
									""data"": ""comments""
								},
								""comments"": {
									""count"": 0,
									""groups_can_post"": true,
									""can_post"": 1
								},
								""likes"": {
									""count"": 0,
									""user_likes"": 0,
									""can_like"": 1,
									""can_publish"": 1
								},
								""reposts"": {
									""count"": 0,
									""user_reposted"": 0
								}
							}
						]
					}
				}
            ";

			var result = Api.Widgets.GetComments(new GetCommentsParams
			{
				WidgetApiId = 5553257,
				Url = "http://griffiny.ru/season-01/4-1-sezon-1-seriya-i-u-smerti-est-ten.html",
				Order = "date",
				Count = 10,
				Offset = 0
			});
			Assert.IsNotEmpty(result);
			Assert.AreEqual(10, result.TotalCount);
		}
	}
}