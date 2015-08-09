package helloworldapp;

import java.io.IOException;
import java.net.URL;
 
import org.apache.commons.io.IOUtils;
import org.json.JSONException;
import org.json.JSONObject;

public class HelloWorldApp {

    public static void main(String[] args) throws IOException, JSONException {
        String url = "http://api.openweathermap.org/data/2.5/weather?q=London,uk";
        String json = IOUtils.toString(new URL(url));
        JSONObject weatherData = new JSONObject(json);
        JSONObject coordinates = weatherData.getJSONObject("coord");
        System.out.println(coordinates.get("lon"));
    }  
    
}
