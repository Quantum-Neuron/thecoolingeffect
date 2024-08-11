import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import About from "./Views/About"
import Homepage from "./Views/Homepage"

const PageRoutes: React.FC = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Homepage />} />
        <Route path="/about" element={<About />} />
        <Route path="*" element={<Homepage />} />
      </Routes>
    </Router>
  );
};

export default PageRoutes;