from django.shortcuts import render
from django.http import HttpResponse
from dietmaker.accounts.models import Diets, Foods, Diet_foods

# Create your views here.

def dietas(request):
	dietas = Diets.objects.filter(user = request.user)
	alimentos = Foods.objects.all()
	ali_in_diet = Diet_foods.objects.all()

	context = {
		"dietas": dietas,
		"alimentos": alimentos,
		"ali_in_diet": ali_in_diet
	}
	return render(request, 'dietas.html', context)

def alimentos(request):
	alimentos = Foods.objects.all()

	context = {
		"alimentos": alimentos
	}

	return render(request, 'alimentos.html', context)