from django.shortcuts import render
from django.http import HttpResponse

# Create your views here.
def aboutus(request):
	return render(request, 'aboutus.html')

def project(request):
	return render(request, 'project.html')

def home(request):
	return render(request, 'home.html')

def contact(request):
	return render(request, 'contact.html')


