//Problem One: Pricey Neighbours



public static int findPriceyNeighbours(double[] prices)
	{
		/// Header: O(n)
		///	n is the array prices
		
		/*
		** sort the array by making a new list
		int i =0
		 is element array[i] bigger than element array[0]
			if not, add element  after 0
			else make element the  index 0 and shift the rest
		i++
			
		display elements 0,1,2
		*/
		int i = 0;
		while(i< prices.length -1)
		{
			
		}

	}
	
	
	
//Problem Two: Common Friends
	
	
	
public static ArrayList<String> commonFriends(ArrayList<String> friendListOne, ArrayList<String> friendListTwo)
	{
		
		/*
			find commen friends between two peoples
			foreach friend in firendlist one
			check friends in friendlist two
			Big O = O(n^2)
			n is the firendlists
			there are two list and we must to an operation on each list
		*/
		
		
		ArrayList<String> commonList = new ArrayList<>();
		
		for(String friendsOne : friendListOne) //for each loop
		{
			for(String friendsTwo : friendListTwo)// nested for each loop
			{
				if(friendsOne == friendsTwo)
				{
					commonList.add(friendsOne);
					
				}else{ }
				
				
			}
			
			
		}
		return commonList;
	}
	
	
	
	
	
	
//Problem Three: Count Divisors
	
	
	
public static int countDivisors(int[] values)
	{
		/*
		count each pair of indexes in that array
		in which the value at the first index is evenly divisble by the value at the second index
			
			
			
		
		*/
		
		
	}
	
	
	
//Problem Four: First Odd Number

public static int findIndexOfFirstOddNumber(int[] numbers)
	{
		
		/*
			find the index of the first odd number
		
		*/
		for(int i =0; i < numbers.length; i++)
			{
				if(numbers[i]%2 == 0)
				{
					System.out.println(i);
					return i;
					break;
				}else{break;}
				
			}
		
		
		
	}
	
	
	
	
