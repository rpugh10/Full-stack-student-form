
def searchWord(word, filePath):
    
    file = open(filePath, "r")
    form1 = ""
    form2 = ""
    form3 = ""
    form4 = ""
    form5 = ""
    i = 0

    form1Counter = 0 
    form2Counter = 0
    form3Counter = 0
    form4Counter = 0
    form5Counter = 0


    while(i < 14):
        form1 += file.readline()
        i = i + 1
    i = 0
    while(i < 8):
        form2 += file.readline()
        i = i + 1
    i = 0
    while(i < 2):
        form3 += file.readline()
        i = i + 1
    i = 0
    while(i < 3):
        form4 += file.readline()
        i = i + 1
    i = 0
    while(i < 3):
        form5 += file.readline()
        i = i + 1
    i = 0

    word = word.lower()

    for w in form1.lower().split():
        if w == word:
            form1Counter = form1Counter + 1
    for w in form2.lower().split():
        if w == word:
            form2Counter = form2Counter + 1
    for w in form3.lower().split():
        if w == word:
            form3Counter = form3Counter + 1
    for w in form4.lower().split():
        if w == word:
            form4Counter = form4Counter + 1
    for w in form5.lower().split():
        if w == word:
            form5Counter = form5Counter + 1
    file.close()
    

    print(word + " appears " + str(form1Counter) + " times in form 1")
    print(word + " appears " + str(form2Counter) + " times in form 2")
    print(word + " appears " + str(form3Counter) + " times in form 3")
    print(word + " appears " + str(form4Counter) + " times in form 4")
    print(word + " appears " + str(form5Counter) + " times in form 5")
import sys #Got these three lines from stack overflow
word = sys.argv[1]
filePath = sys.argv[2]
searchWord(word, filePath)

  
