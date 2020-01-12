def printAverage(scores):
    print("The average test score is %d"%(sum(scores)/len(scores)))


# returns a list of scores entered by the user
def enterScores(numStudents):
    return [int(raw_input("Enter their score: ")) for i in range(numStudents)]


from enterScores import enterScores
from printAverage import printAverage

def main():
    while (True):
        numStudents = int(raw_input("How many students took the test: "))
        scores = enterScores(numStudents)
        printAverage(scores)
        end = raw_input("Do you want to end program? (Enter no to process a new set of scores): ")
        if end == "yes":
            break


main()