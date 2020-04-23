CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] VARCHAR(50) NOT NULL, 
    [Height] INT NOT NULL, 
    [Weight] INT NOT NULL,
	[Sex] VARCHAR(1) NOT NULL,
	[Age] INT NOT NULL,
    [Tdee] INT NULL, 
	PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT UC_Person UNIQUE (Username)
);


CREATE TABLE [dbo].[Meal]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Calories] INT NOT NULL, 
    [Protein] INT NOT NULL, 
    [Carbs] INT NOT NULL, 
    [Fat] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT UC_Person UNIQUE (Name);
);

INSERT INTO User (Username, Height, Weight, Sex, Age, Tdee) VALUES ('BrayPlays', 68, 168, 'M', 2683), ('Arnold Schwarzenegger', 74, 249, 'M', 3006), ('Michael Phelps', 76, 198, 'M', 12000); --12000 during his Olympic run. Wild.

INSERT INTO Meal (Name, Calories, Protein, Carbs, Fat) VALUES ('Cauliflower Hash Brown Egg Cups', 88, 8, 2, 5,), ('Baked Cheddar Ranch Chicken', 276, 30, 7, 13), ('Pesto Chicken and Veggies', 434, 55, 19, 20),
	('Turkey Burgers with Warm Relish',258,23,10,13),('Steak Fajita Roll Ups',339,32,8,19),('Light and Easy Chicken Salad',191,18,13,8),('Chipotle Chicken Bowl',246,28,29,5),('Zucchini Tuna Cakes',280,34,14,11),
	('Chicken Parmesan Zucchini Boats',38,13,18,2),('Roasted Garlic & Herb Chicken and Veggies',253,28,8,12),('Protein Packed Breakfast Burrito',352,25,22,20),('Lemon Basic Chicken with Spinach',349,40,29,8),
	('Turkey Taco Wraps',385,33,23,17),('Balsamic Chicken and Vegatables',458,57,31,10),('Mustard Pork Tenderloin with Grilled Vegatables',366,33,16,20);