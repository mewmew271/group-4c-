import os
from selenium import webdriver

film = input("enter a title")
chromedriver = r"C:\Users\Rob featherstone\chromedriver.exe"
os.environ["webdriver.chrome.driver"] = chromedriver
driver = webdriver.Chrome(chromedriver)
url = "http://www.omdbapi.com/?apikey=b2dd7669&s="+ film
driver.get(url)
