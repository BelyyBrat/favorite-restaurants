# Favorite Restaurants

## C# MVC with Entity Framework Exercise for Epicodus, 03.18.2020

## Pair Program WFH Summary

* **Andriy Veremyeyev & Adela Darmansyah**
* Favorite Restaurants Project
* Struggles: buggy Git Mob, getting a list of objects within an object (solved by using .Where())

## Notes

### Restaurant Class

* RestaurantId
* Name
* Description
* Price Level (score from 1 - 3, 3 for most expensive)
* Rating (score from 1 - 5, 5 for best)
* Type (Bistro, Cafe, Pizzeria, Steakhouse)
* Vegetarian? (Yes/No)
* CuisineId

### Cuisine Class

* CuisineId
* Cuisine Type (Mexican, Chinese, American)

### Functionalities

- User can search for all of a cuisine's restaurants
  - Search criteria: by name, type, vegetarian

### Parking Lot

- Search page without a textbox, use a dropdown (ex. select cheap), how to search for >1 criteria
- Two Forms in one Search page?
- Separate into two searches: 1 with a textbox, 1 without?
- Filter: checkboxes? 
- Visit Further Exploration on the lesson