import { React, useEffect, useState } from 'react';
import '../../assets/css/App.css';
import './Resources.css';
import { Link } from "react-router-dom";
import Toggle from "../Toggle";
import Disclaimer from "../Disclaimer/Disclaimer";

export default function Resources() {

  const [resources, setResources] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(process.env.REACT_APP_RESOURCE_API_URL, { mode: "cors" });
        const json = await response.json();
        setResources(json);

      } catch (error) {
        console.log("error", error);
      }
    };

    fetchData();

  }, []);

  return (
    <div className="container">
        <Toggle />
       <div className="grid">
        {
            resources.map(resource => 
              <article key={resource.id}> 
                <h1>{resource.name}</h1>
                <p className="text">{resource.body}
               </p>
               <Link className="resourceLink" to={`/resources/${resource.id}`}><span>More info</span></Link>

              </article>)}
      </div> 
      <Disclaimer />
   </div> 
  );
}