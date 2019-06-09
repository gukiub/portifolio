from django.shortcuts import render, redirect
from django.http import HttpResponse
from django.contrib.auth.forms import UserCreationForm
from django.conf import settings
from dietmaker.accounts.models import *
from django.contrib.auth import logout


def logout_view(request):
    logout(request)
    return redirect('/')

def dashboard(request):
	template_name = 'accounts/dashboard.html'
	return render(request, template_name)

def register(request):
	template_name = 'accounts/signup.html'
	if request.method == 'POST':
		form = UserCreationForm(request.POST)
		if form.is_valid():
			form.save()
			return redirect(settings.LOGIN_URL)
	else:
		form = UserCreationForm()
	context = {
		'form': form
	}
	return render(request, template_name, context)

def create_diet(request):
	if request.method == "POST":
		name    = request.POST['dietname']
		user_id = request.user

		Diets.objects.create(
			name = name,
			user = user_id
			)
		return redirect("/dietas")
	else:
		return redirect("/dietas")

def create_food(request):
	if request.method == "POST":
		name  = request.POST['name']
		carbo = request.POST['carbo']
		prot  = request.POST['prot']
		fat   = request.POST['fat']
		
		Foods.objects.create(
			name  = name,
	    	carbo = carbo,
	    	prot  = prot,
	    	fat   = fat
	    	)
		return redirect("/alimentos")
	else:
		return redirect("/alimentos")

def rel(request):
	if request.method == "POST":
		food_id_test = request.POST['food_id']
		diet_id_test = request.POST['diet_id']

		Diet_foods.objects.create(
			food = Foods.objects.get(id = food_id_test),
			diet = Diets.objects.get(id = diet_id_test)
			)
		return redirect("/dietas")
	else:
		return redirect("/dietas")

def delete_diet(request): 
	if request.method == "POST": 
		name    = request.POST['dietname'] 
		user_id = request.user 
 
		obj = Diets.objects.get(name = name, user = user_id) 
		relations = Diet_foods.objects.filter(diet = obj) 
		obj.delete() 
		relations.delete() 
		return redirect("/dietas") 
	else: 
		return redirect("/dietas") 

def delete_food(request): 
	if request.method == "POST": 
		name    = request.POST['foodname'] 
 
		obj = Foods.objects.get(name = name) 
		relations = Diet_foods.objects.filter(food = obj) 
		obj.delete() 
		relations.delete() 
		return redirect("/alimentos") 
	else: 
		return redirect("/alimentos") 