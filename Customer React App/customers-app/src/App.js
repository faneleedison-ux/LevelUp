import React from 'react'
import "./App.css";
import Button from 'react-bootstrap/Button';
import { Home } from './Components/Home/Home';

import {BrowserRouter , Route, Routes} from "react-router-dom";
import { Manage } from './Components/Management/Manage';
import {About} from "./Components/About/About";


function App() {
  return (
   

  

      <BrowserRouter>
       <div className='container'>
       <Home/>
      <Routes>
        <Route path ="/" component={Home} exact/>
        <Route path="manage" component={Manage}/>
        <Route path="/about" component={About}/>

      </Routes>
       </div>
      </BrowserRouter>
      
   
  );
}

export default App;