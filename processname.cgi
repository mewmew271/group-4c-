import cgi 

def htmlTop():
    print("""content-type:text/html \n\n
            <!DOCTYPE html>
            <html lang = "en">
                <head>
		<meta charset = "utf-8"/>
        <title>get name </title>
	</head>
	<body>""")
    
def htmlTail():
    print(""" </body>
</html>""")
	
 def getData():
     formData = cgi.FieldStorage()
     firstname = formData.getvalue('firstname')
     return firstname
 
#main program 
    if __name__ == "__main__"
    try:
        htmlTop()
        firstName = getData()#gets the value entered in to the form 
        print("hello {0}".format(firstName))
		print(firstName)
        htmlTail()
    except: 
        cgi.print_exception()