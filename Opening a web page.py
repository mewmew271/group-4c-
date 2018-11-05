from selenium import webdriver #Selenium needs to be installed on spider via command line
import time
br = webdriver.Chrome(executable_path='D:\webDrivers\chromedriver.exe') # path to Chrome driver
br.implicitly_wait(15) # wait's for the page to get done loading before it does anything with it
br.get('http://www.google.com/')
# to fill out a form
search = br.find_element_by_name('q')
search.send_keys('http://www.omdbapi.com/')#enter what ever you want the search results to be
search.submit()
time.sleep(5)
print(br.title)
