using System;
using System.Collections.Generic;

public class Item
{
	public int id;
	public string title;
	public string decription;
	public Dictionary<string, int> stats = new Dictionary<string, int>();
	public int price;
	public string type;

	public Item(int id, string title, string description,  Dictionary<string, int> stats, int price, string type)
	{
		this.id = id;
		this.title = title;
		this.decription = description;
		this.stats = stats;
		this.price = price;
		this.type = type;
	}

	public Item(Item item)
	{
		this.id = item.id;
		this.title = item.title;
		this.decription = item.decription;
		this.stats = item.stats;
		this.price = item.price;
		this.type = item.type;

	}

}
