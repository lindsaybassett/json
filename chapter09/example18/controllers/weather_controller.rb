class WeatherController < ApplicationController
  def index
	require 'net/http'
	require 'json'

	url = URI.parse('http://api.openweathermap.org/data/2.5/weather?q=London,uk')
		request = Net::HTTP::Get.new(url.to_s)
		response = Net::HTTP.start(url.host, url.port) {|http|
		http.request(request)
	}

	weatherData = JSON.parse(response.body)

	render text: weatherData["coord"]["lon"]
	  
  end
end
