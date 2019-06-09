from django.db import models
from django.conf import settings

# Create your models here.

class Foods(models.Model):
	name = models.CharField(max_length=100)
	carbo = models.DecimalField(max_digits=10,decimal_places=2)
	prot = models.DecimalField(max_digits=10,decimal_places=2)
	fat = models.DecimalField(max_digits=10,decimal_places=2)

class Diets(models.Model):
	name = models.CharField(max_length=100)
	user = models.ForeignKey(settings.AUTH_USER_MODEL, on_delete=models.CASCADE)

class Diet_foods(models.Model):
	diet = models.ForeignKey(Diets, on_delete=models.CASCADE)
	food = models.ForeignKey(Foods, on_delete=models.CASCADE)