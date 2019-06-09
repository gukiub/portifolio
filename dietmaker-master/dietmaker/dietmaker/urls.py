"""dietmaker URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/2.2/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.contrib import admin
from django.urls import path, include 
from dietmaker.core import views as core_views
from django.contrib.auth import views as auth_views
from dietmaker.diet import views as diet_views
from dietmaker.accounts import views as accounts_views

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', core_views.home, name='home'),
    path('project/', core_views.project, name='project'),
    path('aboutus/', core_views.aboutus, name='aboutus'),
    path('login/', auth_views.LoginView.as_view(template_name='accounts/signin.html'), name='login'),
    path('register/', accounts_views.register, name='register'),
    path('contact/', core_views.contact, name='contact'),
    path('dietas/', diet_views.dietas, name = 'dietas'),
    path('alimentos/', diet_views.alimentos, name = 'alimentos'),
    path('creatediet', accounts_views.create_diet, name = 'creatediet'),
    path('createfood', accounts_views.create_food, name = 'createfood'),
    path('deletediet', accounts_views.delete_diet, name = 'deletediet'),
    path('deletefood', accounts_views.delete_food, name = 'deletefood'),  
    path('rel', accounts_views.rel, name = 'rel'),
    path('logout', accounts_views.logout_view, name = 'logout'),
    ]
